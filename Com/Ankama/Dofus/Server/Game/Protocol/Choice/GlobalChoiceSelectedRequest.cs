using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice
{
	// Token: 0x020008C7 RID: 2247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GlobalChoiceSelectedRequest : IMessage<GlobalChoiceSelectedRequest>, IMessage, IEquatable<GlobalChoiceSelectedRequest>, IDeepCloneable<GlobalChoiceSelectedRequest>, IBufferMessage
	{
		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x00234120 File Offset: 0x00232320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GlobalChoiceSelectedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06006D32 RID: 27954 RVA: 0x00234130 File Offset: 0x00232330
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x00234140 File Offset: 0x00232340
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

		// Token: 0x06006D34 RID: 27956 RVA: 0x00234150 File Offset: 0x00232350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedRequest()
		{
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x00234160 File Offset: 0x00232360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedRequest(GlobalChoiceSelectedRequest other)
		{
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x00234170 File Offset: 0x00232370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalChoiceSelectedRequest Clone()
		{
			return null;
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x00234180 File Offset: 0x00232380
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x00234190 File Offset: 0x00232390
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x002341A0 File Offset: 0x002323A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x002341B0 File Offset: 0x002323B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GlobalChoiceSelectedRequest other)
		{
			return true;
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x002341C0 File Offset: 0x002323C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x002341D0 File Offset: 0x002323D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x002341E0 File Offset: 0x002323E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x002341F0 File Offset: 0x002323F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00234200 File Offset: 0x00232400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00234210 File Offset: 0x00232410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GlobalChoiceSelectedRequest other)
		{
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00234220 File Offset: 0x00232420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x00234230 File Offset: 0x00232430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x00234240 File Offset: 0x00232440
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalChoiceSelectedRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GlobalChoiceSelectedRequest._parser = new MessageParser<GlobalChoiceSelectedRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00234324 File Offset: 0x00232524
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SrNdrsJAUAHPNMGioSal()
		{
			return true;
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x0023432C File Offset: 0x0023252C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GlobalChoiceSelectedRequest uggPcjJAvv6ejrKeUmQP()
		{
			return null;
		}

		// Token: 0x04002616 RID: 9750
		private static readonly MessageParser<GlobalChoiceSelectedRequest> _parser;

		// Token: 0x04002617 RID: 9751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002618 RID: 9752
		public const int PositionFieldNumber = 1;

		// Token: 0x04002619 RID: 9753
		private int position_;

		// Token: 0x0400261A RID: 9754
		internal static GlobalChoiceSelectedRequest TgWEfRJAcWXOk1aYA1mN;
	}
}
