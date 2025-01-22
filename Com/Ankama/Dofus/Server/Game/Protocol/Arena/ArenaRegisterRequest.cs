using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C0A RID: 3082
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaRegisterRequest : IMessage<ArenaRegisterRequest>, IMessage, IEquatable<ArenaRegisterRequest>, IDeepCloneable<ArenaRegisterRequest>, IBufferMessage
	{
		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x00275B74 File Offset: 0x00273D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaRegisterRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06009414 RID: 37908 RVA: 0x00275B84 File Offset: 0x00273D84
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

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00275B94 File Offset: 0x00273D94
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

		// Token: 0x06009416 RID: 37910 RVA: 0x00275BA4 File Offset: 0x00273DA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegisterRequest()
		{
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00275BB4 File Offset: 0x00273DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegisterRequest(ArenaRegisterRequest other)
		{
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00275BC4 File Offset: 0x00273DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaRegisterRequest Clone()
		{
			return null;
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x00275BD4 File Offset: 0x00273DD4
		// (set) Token: 0x0600941A RID: 37914 RVA: 0x00275BE8 File Offset: 0x00273DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArenaType ArenaType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ArenaType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x00275BF8 File Offset: 0x00273DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x00275C08 File Offset: 0x00273E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaRegisterRequest other)
		{
			return true;
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00275C18 File Offset: 0x00273E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x00275C28 File Offset: 0x00273E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x00275C38 File Offset: 0x00273E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00275C48 File Offset: 0x00273E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00275C58 File Offset: 0x00273E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00275C68 File Offset: 0x00273E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaRegisterRequest other)
		{
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00275C78 File Offset: 0x00273E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00275C88 File Offset: 0x00273E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00275C98 File Offset: 0x00273E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaRegisterRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				ArenaRegisterRequest._parser = new MessageParser<ArenaRegisterRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00275D64 File Offset: 0x00273F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vt5XB7JXODlvLGab7Hoa()
		{
			return true;
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x00275D6C File Offset: 0x00273F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaRegisterRequest tCpIwZJXJPM4nYJ1rLDV()
		{
			return null;
		}

		// Token: 0x04003725 RID: 14117
		private static readonly MessageParser<ArenaRegisterRequest> _parser;

		// Token: 0x04003726 RID: 14118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003727 RID: 14119
		public const int ArenaTypeFieldNumber = 1;

		// Token: 0x04003728 RID: 14120
		private ArenaType arenaType_;

		// Token: 0x04003729 RID: 14121
		private static ArenaRegisterRequest giw0KlJXR2T9TQD9WCSA;
	}
}
