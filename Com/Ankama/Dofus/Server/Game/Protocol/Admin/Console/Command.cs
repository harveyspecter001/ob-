using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console
{
	// Token: 0x02000DB8 RID: 3512
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Command : IMessage<Command>, IMessage, IEquatable<Command>, IDeepCloneable<Command>, IBufferMessage
	{
		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600A92F RID: 43311 RVA: 0x0029673C File Offset: 0x0029493C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Command> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x0029674C File Offset: 0x0029494C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600A931 RID: 43313 RVA: 0x0029675C File Offset: 0x0029495C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x0029676C File Offset: 0x0029496C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Command()
		{
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x0029677C File Offset: 0x0029497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Command(Command other)
		{
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x0029678C File Offset: 0x0029498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Command Clone()
		{
			return null;
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600A935 RID: 43317 RVA: 0x0029679C File Offset: 0x0029499C
		// (set) Token: 0x0600A936 RID: 43318 RVA: 0x002967AC File Offset: 0x002949AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Alias
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600A937 RID: 43319 RVA: 0x002967BC File Offset: 0x002949BC
		// (set) Token: 0x0600A938 RID: 43320 RVA: 0x002967CC File Offset: 0x002949CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Arguments
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x0600A939 RID: 43321 RVA: 0x002967DC File Offset: 0x002949DC
		// (set) Token: 0x0600A93A RID: 43322 RVA: 0x002967EC File Offset: 0x002949EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x002967FC File Offset: 0x002949FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x0029680C File Offset: 0x00294A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Command other)
		{
			return true;
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x0029681C File Offset: 0x00294A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x0029682C File Offset: 0x00294A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x0029683C File Offset: 0x00294A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x0029684C File Offset: 0x00294A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x0029685C File Offset: 0x00294A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x0029686C File Offset: 0x00294A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Command other)
		{
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x0029687C File Offset: 0x00294A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x0029688C File Offset: 0x00294A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x0029689C File Offset: 0x00294A9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Command()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Command._parser = new MessageParser<Command>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x00296968 File Offset: 0x00294B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pdGsXIJcmXP8Iusy5woW()
		{
			return true;
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x00296970 File Offset: 0x00294B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Command jPlQdqJcAouibjPVR2UO()
		{
			return null;
		}

		// Token: 0x04003E32 RID: 15922
		private static readonly MessageParser<Command> _parser;

		// Token: 0x04003E33 RID: 15923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E34 RID: 15924
		public const int AliasFieldNumber = 1;

		// Token: 0x04003E35 RID: 15925
		private string alias_;

		// Token: 0x04003E36 RID: 15926
		public const int ArgumentsFieldNumber = 2;

		// Token: 0x04003E37 RID: 15927
		private string arguments_;

		// Token: 0x04003E38 RID: 15928
		public const int DescriptionFieldNumber = 3;

		// Token: 0x04003E39 RID: 15929
		private string description_;

		// Token: 0x04003E3A RID: 15930
		private static Command eUwD99JcnChoXk9uLvHY;
	}
}
