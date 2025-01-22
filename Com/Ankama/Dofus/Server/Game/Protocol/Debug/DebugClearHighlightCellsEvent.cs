using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug
{
	// Token: 0x020007F1 RID: 2033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DebugClearHighlightCellsEvent : IMessage<DebugClearHighlightCellsEvent>, IMessage, IEquatable<DebugClearHighlightCellsEvent>, IDeepCloneable<DebugClearHighlightCellsEvent>, IBufferMessage
	{
		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06006343 RID: 25411 RVA: 0x0022460C File Offset: 0x0022280C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DebugClearHighlightCellsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x0022461C File Offset: 0x0022281C
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x0022462C File Offset: 0x0022282C
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

		// Token: 0x06006346 RID: 25414 RVA: 0x0022463C File Offset: 0x0022283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugClearHighlightCellsEvent()
		{
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x0022464C File Offset: 0x0022284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugClearHighlightCellsEvent(DebugClearHighlightCellsEvent other)
		{
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x0022465C File Offset: 0x0022285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugClearHighlightCellsEvent Clone()
		{
			return null;
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x0022466C File Offset: 0x0022286C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x0022467C File Offset: 0x0022287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DebugClearHighlightCellsEvent other)
		{
			return true;
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x0022468C File Offset: 0x0022288C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x0022469C File Offset: 0x0022289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x002246AC File Offset: 0x002228AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x002246BC File Offset: 0x002228BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x002246CC File Offset: 0x002228CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x002246DC File Offset: 0x002228DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DebugClearHighlightCellsEvent other)
		{
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x002246EC File Offset: 0x002228EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x002246FC File Offset: 0x002228FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x0022470C File Offset: 0x0022290C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DebugClearHighlightCellsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
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
				DebugClearHighlightCellsEvent._parser = new MessageParser<DebugClearHighlightCellsEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x002247D8 File Offset: 0x002229D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O8jRLWOzOSgrIqjjyy7X()
		{
			return true;
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x002247E0 File Offset: 0x002229E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DebugClearHighlightCellsEvent h5XM1lOzJldDNJM9K5ct()
		{
			return null;
		}

		// Token: 0x040022E1 RID: 8929
		private static readonly MessageParser<DebugClearHighlightCellsEvent> _parser;

		// Token: 0x040022E2 RID: 8930
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E3 RID: 8931
		private static DebugClearHighlightCellsEvent VQiqXbOzRIuHRKISUSSI;
	}
}
