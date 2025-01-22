using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console
{
	// Token: 0x02000DB0 RID: 3504
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ConsoleEnd : IMessage<ConsoleEnd>, IMessage, IEquatable<ConsoleEnd>, IDeepCloneable<ConsoleEnd>, IBufferMessage
	{
		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x002960B0 File Offset: 0x002942B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConsoleEnd> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x002960C0 File Offset: 0x002942C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x002960D0 File Offset: 0x002942D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x002960E0 File Offset: 0x002942E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleEnd()
		{
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x002960F0 File Offset: 0x002942F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleEnd(ConsoleEnd other)
		{
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x00296100 File Offset: 0x00294300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleEnd Clone()
		{
			return null;
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x00296110 File Offset: 0x00294310
		// (set) Token: 0x0600A8E6 RID: 43238 RVA: 0x00296120 File Offset: 0x00294320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x00296130 File Offset: 0x00294330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x00296140 File Offset: 0x00294340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ConsoleEnd other)
		{
			return true;
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x00296150 File Offset: 0x00294350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x00296160 File Offset: 0x00294360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x00296170 File Offset: 0x00294370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x00296180 File Offset: 0x00294380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x00296190 File Offset: 0x00294390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x002961A0 File Offset: 0x002943A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ConsoleEnd other)
		{
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x002961B0 File Offset: 0x002943B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002961C0 File Offset: 0x002943C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x002961D0 File Offset: 0x002943D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConsoleEnd()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ConsoleEnd._parser = new MessageParser<ConsoleEnd>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_C1;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
					}
				}
				IL_C1:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002962B8 File Offset: 0x002944B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BBqb2CJlMkYLSnmesEug()
		{
			return true;
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x002962C0 File Offset: 0x002944C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConsoleEnd L8LNQ5JluYTK3r3FxfvH()
		{
			return null;
		}

		// Token: 0x04003E16 RID: 15894
		private static readonly MessageParser<ConsoleEnd> _parser;

		// Token: 0x04003E17 RID: 15895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E18 RID: 15896
		public const int SuccessFieldNumber = 1;

		// Token: 0x04003E19 RID: 15897
		private bool success_;

		// Token: 0x04003E1A RID: 15898
		private static ConsoleEnd TSKxiXJlSNg8d6oejQmU;
	}
}
