using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200063D RID: 1597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTurnReadyRequest : IMessage<FightTurnReadyRequest>, IMessage, IEquatable<FightTurnReadyRequest>, IDeepCloneable<FightTurnReadyRequest>, IBufferMessage
	{
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x00202FB8 File Offset: 0x002011B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTurnReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x00202FC8 File Offset: 0x002011C8
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

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x00202FD8 File Offset: 0x002011D8
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

		// Token: 0x06004D68 RID: 19816 RVA: 0x00202FE8 File Offset: 0x002011E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnReadyRequest()
		{
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00202FF8 File Offset: 0x002011F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnReadyRequest(FightTurnReadyRequest other)
		{
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00203008 File Offset: 0x00201208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTurnReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06004D6B RID: 19819 RVA: 0x00203018 File Offset: 0x00201218
		// (set) Token: 0x06004D6C RID: 19820 RVA: 0x00203028 File Offset: 0x00201228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
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

		// Token: 0x06004D6D RID: 19821 RVA: 0x00203038 File Offset: 0x00201238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00203048 File Offset: 0x00201248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTurnReadyRequest other)
		{
			return true;
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00203058 File Offset: 0x00201258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00203068 File Offset: 0x00201268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00203078 File Offset: 0x00201278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00203088 File Offset: 0x00201288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00203098 File Offset: 0x00201298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x002030A8 File Offset: 0x002012A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTurnReadyRequest other)
		{
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x002030B8 File Offset: 0x002012B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x002030C8 File Offset: 0x002012C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x002030D8 File Offset: 0x002012D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTurnReadyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					FightTurnReadyRequest._parser = new MessageParser<FightTurnReadyRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x002031BC File Offset: 0x002013BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mrs1LVOiXb9N2YsLS5dU()
		{
			return true;
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x002031C4 File Offset: 0x002013C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTurnReadyRequest g9ZXZwOiNOTCXkjnvvHB()
		{
			return null;
		}

		// Token: 0x04001B03 RID: 6915
		private static readonly MessageParser<FightTurnReadyRequest> _parser;

		// Token: 0x04001B04 RID: 6916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B05 RID: 6917
		public const int IsReadyFieldNumber = 1;

		// Token: 0x04001B06 RID: 6918
		private bool isReady_;

		// Token: 0x04001B07 RID: 6919
		internal static FightTurnReadyRequest n65MB0OiE3UC0q4oUfUq;
	}
}
