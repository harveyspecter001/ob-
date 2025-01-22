using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008EB RID: 2283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerStatusUpdateErrorEvent : IMessage<PlayerStatusUpdateErrorEvent>, IMessage, IEquatable<PlayerStatusUpdateErrorEvent>, IDeepCloneable<PlayerStatusUpdateErrorEvent>, IBufferMessage
	{
		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x0023817C File Offset: 0x0023637C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerStatusUpdateErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x0023818C File Offset: 0x0023638C
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

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06006EFA RID: 28410 RVA: 0x0023819C File Offset: 0x0023639C
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

		// Token: 0x06006EFB RID: 28411 RVA: 0x002381AC File Offset: 0x002363AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateErrorEvent()
		{
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x002381BC File Offset: 0x002363BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateErrorEvent(PlayerStatusUpdateErrorEvent other)
		{
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x002381CC File Offset: 0x002363CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x002381DC File Offset: 0x002363DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x002381EC File Offset: 0x002363EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerStatusUpdateErrorEvent other)
		{
			return true;
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x002381FC File Offset: 0x002363FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x0023820C File Offset: 0x0023640C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x0023821C File Offset: 0x0023641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x0023822C File Offset: 0x0023642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x0023823C File Offset: 0x0023643C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x0023824C File Offset: 0x0023644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerStatusUpdateErrorEvent other)
		{
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x0023825C File Offset: 0x0023645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x0023826C File Offset: 0x0023646C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x0023827C File Offset: 0x0023647C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerStatusUpdateErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					PlayerStatusUpdateErrorEvent._parser = new MessageParser<PlayerStatusUpdateErrorEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x00238360 File Offset: 0x00236560
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fvS1j0JBxuGqHnKxau08()
		{
			return true;
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x00238368 File Offset: 0x00236568
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerStatusUpdateErrorEvent hfnLgEJB4wxq16qLo51J()
		{
			return null;
		}

		// Token: 0x040026E0 RID: 9952
		private static readonly MessageParser<PlayerStatusUpdateErrorEvent> _parser;

		// Token: 0x040026E1 RID: 9953
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026E2 RID: 9954
		private static PlayerStatusUpdateErrorEvent oDneW3JBNKktfQWDIEtZ;
	}
}
